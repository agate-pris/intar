using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
    public struct Vector3I4F60
    : IEquatable<Vector3I4F60>
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
        public I4F60 X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr.X);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.X = value.Bits;
        }
        public I4F60 Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr.Y);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Y = value.Bits;
        }
        public I4F60 Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr.Z);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr.Z = value.Bits;
        }
        #endregion

        public I4F60 this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => I4F60.FromBits(Repr[index]);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Repr[index] = value.Bits;
        }

        public static explicit operator System.Numerics.Vector3(Vector3I4F60 a) {
            return (System.Numerics.Vector3)a.Repr / I4F60.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector3(Vector3I4F60 a) {
            return (UnityEngine.Vector3)a.Repr / I4F60.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float3(Vector3I4F60 a) {
            return (Unity.Mathematics.float3)a.Repr / I4F60.OneRepr;
        }
#endif

        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I4F60(Vector3Int64 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F60(I4F60 x, I4F60 y, I4F60 z) : this(new Vector3Int64(x.Bits, y.Bits, z.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F60(I4F60 value) : this(value, value, value) { }

        #endregion

        #region Zero, One, UnitX, UnitY, UnitZ

        public static readonly Vector3I4F60 Zero = new Vector3I4F60(I4F60.Zero);
        public static readonly Vector3I4F60 One = new Vector3I4F60(I4F60.One);
        public static readonly Vector3I4F60 UnitX = new Vector3I4F60(I4F60.One, I4F60.Zero, I4F60.Zero);
        public static readonly Vector3I4F60 UnitY = new Vector3I4F60(I4F60.Zero, I4F60.One, I4F60.Zero);
        public static readonly Vector3I4F60 UnitZ = new Vector3I4F60(I4F60.Zero, I4F60.Zero, I4F60.One);

        #endregion

        #region IAdditionOperators, ISubtractionOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator +(Vector3I4F60 a, Vector3I4F60 b) {
            return new Vector3I4F60(a.Repr + b.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator -(Vector3I4F60 a, Vector3I4F60 b) {
            return new Vector3I4F60(a.Repr - b.Repr);
        }

        #endregion

        #region IMultiplyOperators, IDivisionOperators

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator *(Vector3I4F60 a, Vector3I4F60 b) {
            return new Vector3I4F60((Vector3Int64)(a.WideRepr * b.WideRepr / I4F60.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator *(Vector3I4F60 a, I4F60 b) {
            return new Vector3I4F60((Vector3Int64)(a.WideRepr * b.Bits / I4F60.OneRepr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator *(I4F60 a, Vector3I4F60 b) {
            return b * a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator /(Vector3I4F60 a, Vector3I4F60 b) {
            return new Vector3I4F60((Vector3Int64)(a.WideRepr * I4F60.OneRepr / b.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator /(Vector3I4F60 a, I4F60 b) {
            return new Vector3I4F60((Vector3Int64)(a.WideRepr * I4F60.OneRepr / b.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator /(I4F60 a, Vector3I4F60 b) {
            return new Vector3I4F60((Vector3Int64)(a.WideBits * I4F60.OneRepr / b.WideRepr));
        }

#endif // NET7_0_OR_GREATER

        #endregion

        #region IUnaryPlusOperators, IUnaryNegationOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator +(Vector3I4F60 x) {
            return new Vector3I4F60(+x.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I4F60 operator -(Vector3I4F60 x) {
            return new Vector3I4F60(-x.Repr);
        }

        #endregion

        #region IEqualityOperators

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator ==(Vector3I4F60 lhs, Vector3I4F60 rhs) => lhs.Repr == rhs.Repr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Bool operator !=(Vector3I4F60 lhs, Vector3I4F60 rhs) => lhs.Repr != rhs.Repr;

        #endregion

        public Vector3Bool IsNegative() => Repr.IsNegative();

        #region Object

        public override bool Equals(object obj) => obj is Vector3I4F60 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}, {Z}>";

        #endregion

        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector3I4F60 other) {
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
        public Vector3I4F60 Min(Vector3I4F60 other) {
            return new Vector3I4F60(Repr.Min(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F60 Max(Vector3I4F60 other) {
            return new Vector3I4F60(Repr.Max(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F60 Clamp(I4F60 min, I4F60 max) {
            return new Vector3I4F60(Repr.Clamp(min.Bits, max.Bits));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F60 Clamp(Vector3I4F60 min, Vector3I4F60 max) {
            return new Vector3I4F60(Repr.Clamp(min.Repr, max.Repr));
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F60 Abs() => new Vector3I4F60(Repr.Abs());

        #region Half, Twice

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I4F60 Half() => new Vector3I4F60(Repr.Half());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector3I4F60 Twice() => new Vector3I4F60(Repr.Twice());

        #endregion

#if NET7_0_OR_GREATER

        #region Cross, UncheckedDot, (Unchecked)LengthSquared, (Unchecked)Length

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I8F120 Cross(Vector3I4F60 other) {
            var tmp = Repr.Cross(other.Repr);
            return new Vector3I8F120(tmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I8F120 UncheckedDot(Vector3I4F60 other) {
            return I8F120.FromBits(Repr.UncheckedDot(other.Repr));
        }

        /// <summary>
        /// <para>Returns the length of the vector squared.</para>
        /// <para>ベクトルの長さの 2 乗を返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U8F120 LengthSquared() => U8F120.FromBits(Repr.LengthSquared());

        /// <summary>
        /// <para>Returns the length of the vector.</para>
        /// <para>ベクトルの長さを返します｡</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U4F60 Length() => U4F60.FromBits(Repr.Length());

        #endregion

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

            const ulong fracOneTwo = I4F60.OneRepr / 2;
            var absNormalized = (Vector3Int64)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector3Int64(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y,
                isNegative.Z ? -absNormalized.Z : absNormalized.Z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I4F60? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector3I4F60(tmp.Value);
        }

#endif // NET7_0_OR_GREATER

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XX() => new Vector2I4F60(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XY() => new Vector2I4F60(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 XZ() => new Vector2I4F60(Repr.XZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YX() => new Vector2I4F60(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YY() => new Vector2I4F60(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 YZ() => new Vector2I4F60(Repr.YZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 ZX() => new Vector2I4F60(Repr.ZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 ZY() => new Vector2I4F60(Repr.ZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I4F60 ZZ() => new Vector2I4F60(Repr.ZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXX() => new Vector3I4F60(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXY() => new Vector3I4F60(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XXZ() => new Vector3I4F60(Repr.XXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYX() => new Vector3I4F60(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYY() => new Vector3I4F60(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XYZ() => new Vector3I4F60(Repr.XYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XZX() => new Vector3I4F60(Repr.XZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XZY() => new Vector3I4F60(Repr.XZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 XZZ() => new Vector3I4F60(Repr.XZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXX() => new Vector3I4F60(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXY() => new Vector3I4F60(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YXZ() => new Vector3I4F60(Repr.YXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYX() => new Vector3I4F60(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYY() => new Vector3I4F60(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YYZ() => new Vector3I4F60(Repr.YYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YZX() => new Vector3I4F60(Repr.YZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YZY() => new Vector3I4F60(Repr.YZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 YZZ() => new Vector3I4F60(Repr.YZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZXX() => new Vector3I4F60(Repr.ZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZXY() => new Vector3I4F60(Repr.ZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZXZ() => new Vector3I4F60(Repr.ZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZYX() => new Vector3I4F60(Repr.ZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZYY() => new Vector3I4F60(Repr.ZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZYZ() => new Vector3I4F60(Repr.ZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZZX() => new Vector3I4F60(Repr.ZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZZY() => new Vector3I4F60(Repr.ZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I4F60 ZZZ() => new Vector3I4F60(Repr.ZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXX() => new Vector4I4F60(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXY() => new Vector4I4F60(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXXZ() => new Vector4I4F60(Repr.XXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYX() => new Vector4I4F60(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYY() => new Vector4I4F60(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXYZ() => new Vector4I4F60(Repr.XXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXZX() => new Vector4I4F60(Repr.XXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXZY() => new Vector4I4F60(Repr.XXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XXZZ() => new Vector4I4F60(Repr.XXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXX() => new Vector4I4F60(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXY() => new Vector4I4F60(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYXZ() => new Vector4I4F60(Repr.XYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYX() => new Vector4I4F60(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYY() => new Vector4I4F60(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYYZ() => new Vector4I4F60(Repr.XYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYZX() => new Vector4I4F60(Repr.XYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYZY() => new Vector4I4F60(Repr.XYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XYZZ() => new Vector4I4F60(Repr.XYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZXX() => new Vector4I4F60(Repr.XZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZXY() => new Vector4I4F60(Repr.XZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZXZ() => new Vector4I4F60(Repr.XZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZYX() => new Vector4I4F60(Repr.XZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZYY() => new Vector4I4F60(Repr.XZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZYZ() => new Vector4I4F60(Repr.XZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZZX() => new Vector4I4F60(Repr.XZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZZY() => new Vector4I4F60(Repr.XZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 XZZZ() => new Vector4I4F60(Repr.XZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXX() => new Vector4I4F60(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXY() => new Vector4I4F60(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXXZ() => new Vector4I4F60(Repr.YXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYX() => new Vector4I4F60(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYY() => new Vector4I4F60(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXYZ() => new Vector4I4F60(Repr.YXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXZX() => new Vector4I4F60(Repr.YXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXZY() => new Vector4I4F60(Repr.YXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YXZZ() => new Vector4I4F60(Repr.YXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXX() => new Vector4I4F60(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXY() => new Vector4I4F60(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYXZ() => new Vector4I4F60(Repr.YYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYX() => new Vector4I4F60(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYY() => new Vector4I4F60(Repr.YYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYYZ() => new Vector4I4F60(Repr.YYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYZX() => new Vector4I4F60(Repr.YYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYZY() => new Vector4I4F60(Repr.YYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YYZZ() => new Vector4I4F60(Repr.YYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZXX() => new Vector4I4F60(Repr.YZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZXY() => new Vector4I4F60(Repr.YZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZXZ() => new Vector4I4F60(Repr.YZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZYX() => new Vector4I4F60(Repr.YZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZYY() => new Vector4I4F60(Repr.YZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZYZ() => new Vector4I4F60(Repr.YZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZZX() => new Vector4I4F60(Repr.YZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZZY() => new Vector4I4F60(Repr.YZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 YZZZ() => new Vector4I4F60(Repr.YZZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXXX() => new Vector4I4F60(Repr.ZXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXXY() => new Vector4I4F60(Repr.ZXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXXZ() => new Vector4I4F60(Repr.ZXXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXYX() => new Vector4I4F60(Repr.ZXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXYY() => new Vector4I4F60(Repr.ZXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXYZ() => new Vector4I4F60(Repr.ZXYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXZX() => new Vector4I4F60(Repr.ZXZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXZY() => new Vector4I4F60(Repr.ZXZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZXZZ() => new Vector4I4F60(Repr.ZXZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYXX() => new Vector4I4F60(Repr.ZYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYXY() => new Vector4I4F60(Repr.ZYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYXZ() => new Vector4I4F60(Repr.ZYXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYYX() => new Vector4I4F60(Repr.ZYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYYY() => new Vector4I4F60(Repr.ZYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYYZ() => new Vector4I4F60(Repr.ZYYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYZX() => new Vector4I4F60(Repr.ZYZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYZY() => new Vector4I4F60(Repr.ZYZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZYZZ() => new Vector4I4F60(Repr.ZYZZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZXX() => new Vector4I4F60(Repr.ZZXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZXY() => new Vector4I4F60(Repr.ZZXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZXZ() => new Vector4I4F60(Repr.ZZXZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZYX() => new Vector4I4F60(Repr.ZZYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZYY() => new Vector4I4F60(Repr.ZZYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZYZ() => new Vector4I4F60(Repr.ZZYZ());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZZX() => new Vector4I4F60(Repr.ZZZX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZZY() => new Vector4I4F60(Repr.ZZZY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I4F60 ZZZZ() => new Vector4I4F60(Repr.ZZZZ());

        #endregion

    }
} // namespace Intar1991
