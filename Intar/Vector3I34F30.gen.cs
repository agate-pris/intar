using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector3I34F30
    : IEquatable<Vector3I34F30>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector3Int64 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region WideRepr

#if NET7_0_OR_GREATER

        internal Vector3Int128 WideRepr {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Repr;
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region Components
        public I34F30 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I34F30 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }
        public I34F30 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }
        #endregion
        #region Indexer
        public I34F30 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I34F30.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }
        #endregion
        #region Conversion
        public static explicit operator System.Numerics.Vector3(Vector3I34F30 a) {
            return (System.Numerics.Vector3)a.Repr / I34F30.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3I34F30 a) {
            return (UnityEngine.Vector3)a.Repr / I34F30.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3I34F30 a) {
            return (Unity.Mathematics.float3)a.Repr / I34F30.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector3I34F30(Vector3Int64 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30(I34F30 x, I34F30 y, I34F30 z) : this(new Vector3Int64(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30(I34F30 value) : this(value, value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 FromRepr(Vector3Int64 repr) {
            return new Vector3I34F30(repr);
        }
        #endregion
        #region Zero, One, UnitX, UnitY, UnitZ
        public static readonly Vector3I34F30 Zero = new Vector3I34F30(I34F30.Zero);
        public static readonly Vector3I34F30 One = new Vector3I34F30(I34F30.One);
        public static readonly Vector3I34F30 UnitX = new Vector3I34F30(I34F30.One, I34F30.Zero, I34F30.Zero);
        public static readonly Vector3I34F30 UnitY = new Vector3I34F30(I34F30.Zero, I34F30.One, I34F30.Zero);
        public static readonly Vector3I34F30 UnitZ = new Vector3I34F30(I34F30.Zero, I34F30.Zero, I34F30.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator +(Vector3I34F30 a, Vector3I34F30 b) {
            return new Vector3I34F30(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator -(Vector3I34F30 a, Vector3I34F30 b) {
            return new Vector3I34F30(a.Repr - b.Repr);
        }
        #endregion
        #region IMultiplyOperators, IDivisionOperators

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator *(Vector3I34F30 a, Vector3I34F30 b) {
            return new Vector3I34F30((Vector3Int64)(a.WideRepr * b.WideRepr / I34F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator *(Vector3I34F30 a, I34F30 b) {
            return new Vector3I34F30((Vector3Int64)(a.WideRepr * b.Bits / I34F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator *(I34F30 a, Vector3I34F30 b) {
            return b * a;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator /(Vector3I34F30 a, Vector3I34F30 b) {
            return new Vector3I34F30((Vector3Int64)(a.WideRepr * I34F30.OneRepr / b.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator /(Vector3I34F30 a, I34F30 b) {
            return new Vector3I34F30((Vector3Int64)(a.WideRepr * I34F30.OneRepr / b.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator /(I34F30 a, Vector3I34F30 b) {
            return new Vector3I34F30((Vector3Int64)(a.WideBits * I34F30.OneRepr / b.WideRepr));
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator +(Vector3I34F30 x) {
            return new Vector3I34F30(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I34F30 operator -(Vector3I34F30 x) {
            return new Vector3I34F30(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3I34F30 lhs, Vector3I34F30 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3I34F30 lhs, Vector3I34F30 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector3I34F30 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I34F30 other) {
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
        public Vector3I34F30 Min(Vector3I34F30 other) {
            return new Vector3I34F30(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Max(Vector3I34F30 other) {
            return new Vector3I34F30(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Clamp(I34F30 min, I34F30 max) {
            return new Vector3I34F30(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Clamp(Vector3I34F30 min, Vector3I34F30 max) {
            return new Vector3I34F30(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector3Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30 Abs() => new Vector3I34F30(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I34F30 Half() => new Vector3I34F30(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I34F30 Twice() => new Vector3I34F30(Repr.Twice());
        #endregion

#if NET7_0_OR_GREATER

        #region Cross, Dot, LengthSquared, Length, DistanceSquared, Distance
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I68F60 Cross(Vector3I34F30 other) {
            var tmp = Repr.Cross(other.Repr);
            return Vector3I68F60.FromRepr(tmp);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 Dot(Vector3I34F30 other) {
            return I68F60.FromBits(Repr.Dot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U68F60 LengthSquared() => U68F60.FromBits(Repr.LengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 Length() => U34F30.FromBits(Repr.Length());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U68F60 DistanceSquared(Vector3I34F30 other) {
            return U68F60.FromBits(Repr.DistanceSquared(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 Distance(Vector3I34F30 other) {
            return U34F30.FromBits(Repr.Distance(other.Repr));
        }
        #endregion
        #region Normalize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector3Int64? Normalize(Vector3Int64 v) {

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

            var scaled = abs * (ulong.MaxValue / maxComponent);

            var halfLength = scaled.HalfLength();

            const ulong fracOneTwo = I34F30.OneRepr / 2;
            var absNormalized = (Vector3Int64)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector3Int64(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y,
                isNegative.Z ? -absNormalized.Z : absNormalized.Z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I34F30? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector3I34F30(tmp.Value);
        }
        #endregion

#endif // NET7_0_OR_GREATER

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XX() => Vector2I34F30.FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XY() => Vector2I34F30.FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XZ() => Vector2I34F30.FromRepr(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YX() => Vector2I34F30.FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YY() => Vector2I34F30.FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YZ() => Vector2I34F30.FromRepr(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 ZX() => Vector2I34F30.FromRepr(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 ZY() => Vector2I34F30.FromRepr(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 ZZ() => Vector2I34F30.FromRepr(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXX() => FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXY() => FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXZ() => FromRepr(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYX() => FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYY() => FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYZ() => FromRepr(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XZX() => FromRepr(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XZY() => FromRepr(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XZZ() => FromRepr(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXX() => FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXY() => FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXZ() => FromRepr(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYX() => FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYY() => FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYZ() => FromRepr(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YZX() => FromRepr(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YZY() => FromRepr(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YZZ() => FromRepr(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZXX() => FromRepr(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZXY() => FromRepr(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZXZ() => FromRepr(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZYX() => FromRepr(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZYY() => FromRepr(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZYZ() => FromRepr(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZZX() => FromRepr(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZZY() => FromRepr(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 ZZZ() => FromRepr(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXX() => Vector4I34F30.FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXY() => Vector4I34F30.FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXZ() => Vector4I34F30.FromRepr(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYX() => Vector4I34F30.FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYY() => Vector4I34F30.FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYZ() => Vector4I34F30.FromRepr(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXZX() => Vector4I34F30.FromRepr(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXZY() => Vector4I34F30.FromRepr(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXZZ() => Vector4I34F30.FromRepr(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXX() => Vector4I34F30.FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXY() => Vector4I34F30.FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXZ() => Vector4I34F30.FromRepr(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYX() => Vector4I34F30.FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYY() => Vector4I34F30.FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYZ() => Vector4I34F30.FromRepr(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYZX() => Vector4I34F30.FromRepr(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYZY() => Vector4I34F30.FromRepr(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYZZ() => Vector4I34F30.FromRepr(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZXX() => Vector4I34F30.FromRepr(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZXY() => Vector4I34F30.FromRepr(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZXZ() => Vector4I34F30.FromRepr(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZYX() => Vector4I34F30.FromRepr(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZYY() => Vector4I34F30.FromRepr(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZYZ() => Vector4I34F30.FromRepr(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZZX() => Vector4I34F30.FromRepr(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZZY() => Vector4I34F30.FromRepr(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XZZZ() => Vector4I34F30.FromRepr(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXX() => Vector4I34F30.FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXY() => Vector4I34F30.FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXZ() => Vector4I34F30.FromRepr(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYX() => Vector4I34F30.FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYY() => Vector4I34F30.FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYZ() => Vector4I34F30.FromRepr(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXZX() => Vector4I34F30.FromRepr(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXZY() => Vector4I34F30.FromRepr(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXZZ() => Vector4I34F30.FromRepr(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXX() => Vector4I34F30.FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXY() => Vector4I34F30.FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXZ() => Vector4I34F30.FromRepr(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYX() => Vector4I34F30.FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYY() => Vector4I34F30.FromRepr(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYZ() => Vector4I34F30.FromRepr(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYZX() => Vector4I34F30.FromRepr(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYZY() => Vector4I34F30.FromRepr(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYZZ() => Vector4I34F30.FromRepr(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZXX() => Vector4I34F30.FromRepr(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZXY() => Vector4I34F30.FromRepr(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZXZ() => Vector4I34F30.FromRepr(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZYX() => Vector4I34F30.FromRepr(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZYY() => Vector4I34F30.FromRepr(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZYZ() => Vector4I34F30.FromRepr(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZZX() => Vector4I34F30.FromRepr(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZZY() => Vector4I34F30.FromRepr(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YZZZ() => Vector4I34F30.FromRepr(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXXX() => Vector4I34F30.FromRepr(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXXY() => Vector4I34F30.FromRepr(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXXZ() => Vector4I34F30.FromRepr(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXYX() => Vector4I34F30.FromRepr(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXYY() => Vector4I34F30.FromRepr(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXYZ() => Vector4I34F30.FromRepr(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXZX() => Vector4I34F30.FromRepr(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXZY() => Vector4I34F30.FromRepr(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZXZZ() => Vector4I34F30.FromRepr(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYXX() => Vector4I34F30.FromRepr(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYXY() => Vector4I34F30.FromRepr(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYXZ() => Vector4I34F30.FromRepr(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYYX() => Vector4I34F30.FromRepr(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYYY() => Vector4I34F30.FromRepr(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYYZ() => Vector4I34F30.FromRepr(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYZX() => Vector4I34F30.FromRepr(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYZY() => Vector4I34F30.FromRepr(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZYZZ() => Vector4I34F30.FromRepr(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZXX() => Vector4I34F30.FromRepr(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZXY() => Vector4I34F30.FromRepr(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZXZ() => Vector4I34F30.FromRepr(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZYX() => Vector4I34F30.FromRepr(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZYY() => Vector4I34F30.FromRepr(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZYZ() => Vector4I34F30.FromRepr(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZZX() => Vector4I34F30.FromRepr(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZZY() => Vector4I34F30.FromRepr(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 ZZZZ() => Vector4I34F30.FromRepr(Repr.ZZZZ());
        #endregion
    }
} // namespace Intar
