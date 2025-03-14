using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
    public struct Vector2I34F30
    : IEquatable<Vector2I34F30>
    , IFormattable {
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2Int64 Repr;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region WideRepr

#if NET7_0_OR_GREATER

        internal Vector2Int128 WideRepr {
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
        public static explicit operator System.Numerics.Vector2(Vector2I34F30 a) {
            return (System.Numerics.Vector2)a.Repr / I34F30.OneRepr;
        }

#if UNITY_5_3_OR_NEWER
        public static explicit operator UnityEngine.Vector2(Vector2I34F30 a) {
            return (UnityEngine.Vector2)a.Repr / I34F30.OneRepr;
        }
#endif

#if UNITY_2018_1_OR_NEWER
        public static explicit operator Unity.Mathematics.float2(Vector2I34F30 a) {
            return (Unity.Mathematics.float2)a.Repr / I34F30.OneRepr;
        }
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Vector2I34F30(Vector2Int64 repr) {
            Repr = repr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30(I34F30 x, I34F30 y) : this(new Vector2Int64(x.Bits, y.Bits)) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30(I34F30 value) : this(value, value) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 FromRepr(Vector2Int64 repr) {
            return new Vector2I34F30(repr);
        }
        #endregion
        #region Zero, One, NegativeOne, UnitX, UnitY
        public static readonly Vector2I34F30 Zero = new Vector2I34F30(I34F30.Zero);
        public static readonly Vector2I34F30 One = new Vector2I34F30(I34F30.One);
        public static readonly Vector2I34F30 NegativeOne = new Vector2I34F30(I34F30.NegativeOne);
        public static readonly Vector2I34F30 UnitX = new Vector2I34F30(I34F30.One, I34F30.Zero);
        public static readonly Vector2I34F30 UnitY = new Vector2I34F30(I34F30.Zero, I34F30.One);
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator +(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30(a.Repr + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator +(I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30(a.Bits + b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator +(Vector2I34F30 a, I34F30 b) {
            return new Vector2I34F30(a.Repr + b.Bits);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator -(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30(a.Repr - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator -(I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30(a.Bits - b.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator -(Vector2I34F30 a, I34F30 b) {
            return new Vector2I34F30(a.Repr - b.Bits);
        }
        #endregion
        #region IMultiplyOperators, IDivisionOperators

#if NET7_0_OR_GREATER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator *(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * b.WideRepr / I34F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator *(Vector2I34F30 a, I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * b.Bits / I34F30.OneRepr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator *(I34F30 a, Vector2I34F30 b) {
            return b * a;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator /(Vector2I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * I34F30.OneRepr / b.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator /(Vector2I34F30 a, I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideRepr * I34F30.OneRepr / b.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator /(I34F30 a, Vector2I34F30 b) {
            return new Vector2I34F30((Vector2Int64)(a.WideBits * I34F30.OneRepr / b.WideRepr));
        }

#endif // NET7_0_OR_GREATER

        #endregion
        #region IUnaryPlusOperators, IUnaryNegationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator +(Vector2I34F30 x) {
            return new Vector2I34F30(+x.Repr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I34F30 operator -(Vector2I34F30 x) {
            return new Vector2I34F30(-x.Repr);
        }
        #endregion
        #region IEqualityOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator ==(Vector2I34F30 lhs, Vector2I34F30 rhs) => lhs.Repr == rhs.Repr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Bool operator !=(Vector2I34F30 lhs, Vector2I34F30 rhs) => lhs.Repr != rhs.Repr;
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Vector2I34F30 o && Equals(o);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Repr.GetHashCode();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"<{X}, {Y}>";
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector2I34F30 other) {
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
        public Vector2I34F30 Min(Vector2I34F30 other) {
            return new Vector2I34F30(Repr.Min(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Max(Vector2I34F30 other) {
            return new Vector2I34F30(Repr.Max(other.Repr));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Clamp(I34F30 min, I34F30 max) {
            return new Vector2I34F30(Repr.Clamp(min.Bits, max.Bits));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Clamp(Vector2I34F30 min, Vector2I34F30 max) {
            return new Vector2I34F30(Repr.Clamp(min.Repr, max.Repr));
        }
        #endregion
        #region IsNegative, Abs
        public Vector2Bool IsNegative() => Repr.IsNegative();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30 Abs() => new Vector2I34F30(Repr.Abs());

        // 符号なし固定小数点数ベクトル型は定義されていないため
        // UnsignedAbs と AbsDiff は定義されない.
        #endregion
        #region Half, Twice
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I34F30 Half() => new Vector2I34F30(Repr.Half());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal Vector2I34F30 Twice() => new Vector2I34F30(Repr.Twice());
        #endregion

#if NET7_0_OR_GREATER

        #region Determinant, Dot, LengthSquared, Length, DistanceSquared, Distance

        /// <summary>
        /// <para>Calculates the determinant of matrix.</para>
        /// </summary>
        /// <example>
        /// <code>
        /// var a = new Vector2I34F30(I34F30.FromBits(1), I34F30.FromBits(2));
        /// var b = new Vector2I34F30(I34F30.FromBits(3), I34F30.FromBits(4));
        /// var c = a.Determinant(b);
        /// Assert.AreEqual(I68F60.FromBits((int128)-2), c);
        /// </code>
        /// </example>
        /// <returns>Returns this.X * other.Y - other.X * this.Y.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 Determinant(Vector2I34F30 other) {
            var tmp = Repr.Determinant(other.Repr);
            return I68F60.FromBits(tmp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public I68F60 Dot(Vector2I34F30 other) {
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
        public U68F60 DistanceSquared(Vector2I34F30 other) {
            return U68F60.FromBits(Repr.DistanceSquared(other.Repr));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U34F30 Distance(Vector2I34F30 other) {
            return U34F30.FromBits(Repr.Distance(other.Repr));
        }
        #endregion
        #region Normalize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector2Int64? Normalize(Vector2Int64 v) {

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
            var absNormalized = (Vector2Int64)(scaled.BigMul(fracOneTwo) / halfLength);

            return new Vector2Int64(
                isNegative.X ? -absNormalized.X : absNormalized.X,
                isNegative.Y ? -absNormalized.Y : absNormalized.Y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector2I34F30? Normalize() {
            var tmp = Normalize(Repr);
            if (tmp == null) {
                return null;
            }
            return new Vector2I34F30(tmp.Value);
        }
        #endregion

#endif // NET7_0_OR_GREATER

        #region Swizzling

        // プロパティないしフィールドではないことを明示するためにメソッドとして定義

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 X0() => FromRepr(Repr.X0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 X1() => FromRepr(Repr.X1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XX() => FromRepr(Repr.XX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 XY() => FromRepr(Repr.XY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YX() => FromRepr(Repr.YX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector2I34F30 YY() => FromRepr(Repr.YY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XY0() => Vector3I34F30.FromRepr(Repr.XY0());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XY1() => Vector3I34F30.FromRepr(Repr.XY1());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXX() => Vector3I34F30.FromRepr(Repr.XXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XXY() => Vector3I34F30.FromRepr(Repr.XXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYX() => Vector3I34F30.FromRepr(Repr.XYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 XYY() => Vector3I34F30.FromRepr(Repr.XYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXX() => Vector3I34F30.FromRepr(Repr.YXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YXY() => Vector3I34F30.FromRepr(Repr.YXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYX() => Vector3I34F30.FromRepr(Repr.YYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector3I34F30 YYY() => Vector3I34F30.FromRepr(Repr.YYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXX() => Vector4I34F30.FromRepr(Repr.XXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXXY() => Vector4I34F30.FromRepr(Repr.XXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYX() => Vector4I34F30.FromRepr(Repr.XXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XXYY() => Vector4I34F30.FromRepr(Repr.XXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXX() => Vector4I34F30.FromRepr(Repr.XYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYXY() => Vector4I34F30.FromRepr(Repr.XYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYX() => Vector4I34F30.FromRepr(Repr.XYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 XYYY() => Vector4I34F30.FromRepr(Repr.XYYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXX() => Vector4I34F30.FromRepr(Repr.YXXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXXY() => Vector4I34F30.FromRepr(Repr.YXXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYX() => Vector4I34F30.FromRepr(Repr.YXYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YXYY() => Vector4I34F30.FromRepr(Repr.YXYY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXX() => Vector4I34F30.FromRepr(Repr.YYXX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYXY() => Vector4I34F30.FromRepr(Repr.YYXY());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYX() => Vector4I34F30.FromRepr(Repr.YYYX());
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public Vector4I34F30 YYYY() => Vector4I34F30.FromRepr(Repr.YYYY());
        #endregion
    }
} // namespace Intar
