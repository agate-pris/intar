using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct Matrix2x2I2F30 : IEquatable<Matrix2x2I2F30>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Vector2I2F30 C0;
        public Vector2I2F30 C1;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Construction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Matrix2x2I2F30(Vector2Int32 c0Repr, Vector2Int32 c1Repr) {
            C0 = Vector2I2F30.FromRepr(c0Repr);
            C1 = Vector2I2F30.FromRepr(c1Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix2x2I2F30(Vector2I2F30 c0, Vector2I2F30 c1)
            : this(c0.Repr, c1.Repr) { }
        #endregion
        #region Identity
        public static readonly Matrix2x2I2F30 Identity = new Matrix2x2I2F30(
            new Vector2Int32(I2F30.OneRepr, 0),
            new Vector2Int32(0, I2F30.OneRepr)
        );
        #endregion
        #region Zero
        public static readonly Matrix2x2I2F30 Zero = new Matrix2x2I2F30(
            new Vector2Int32(0, 0),
            new Vector2Int32(0, 0)
        );
        #endregion
        #region Properties
        public Vector2I2F30 R0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector2I2F30.FromRepr(new Vector2Int32(C0.Repr.X, C1.Repr.X));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0.Repr.X = value.Repr.X;
                C1.Repr.X = value.Repr.Y;
            }
        }
        public Vector2I2F30 R1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector2I2F30.FromRepr(new Vector2Int32(C0.Repr.Y, C1.Repr.Y));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0.Repr.Y = value.Repr.X;
                C1.Repr.Y = value.Repr.Y;
            }
        }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix2x2I2F30 other) =>
            C0.Equals(other.C0) &&
            C1.Equals(other.C1);
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Matrix2x2I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0, C1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"{{ {{C0.X:{C0.X} C1.X:{C1.X}}} {{C0.Y:{C0.Y} C1.Y:{C1.Y}}} }}";
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{ {{C0.X:{C0.X.ToString(format, formatProvider)} C1.X:{C1.X.ToString(format, formatProvider)}}} {{C0.Y:{C0.Y.ToString(format, formatProvider)} C1.Y:{C1.Y.ToString(format, formatProvider)}}} }}";
        }
        #endregion
        #region Conversions

#if UNITY_2018_1_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float2x2(Matrix2x2I2F30 a) {
            return new Unity.Mathematics.float2x2(
                (float)a.C0.X, (float)a.C1.X,
                (float)a.C0.Y, (float)a.C1.Y
            );
        }

#endif // UNITY_2018_1_OR_NEWER

        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2I2F30 operator +(Matrix2x2I2F30 left, Matrix2x2I2F30 right) {
            return new Matrix2x2I2F30(
                left.C0 + right.C0,
                left.C1 + right.C1
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2I2F30 operator -(Matrix2x2I2F30 left, Matrix2x2I2F30 right) {
            return new Matrix2x2I2F30(
                left.C0 - right.C0,
                left.C1 - right.C1
            );
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2I2F30 operator *(Matrix2x2I2F30 left, Matrix2x2I2F30 right) {
            return new Matrix2x2I2F30(
                new Vector2I2F30(
                    (I2F30)left.R0.Dot(right.C0),
                    (I2F30)left.R1.Dot(right.C0)
                ),
                new Vector2I2F30(
                    (I2F30)left.R0.Dot(right.C1),
                    (I2F30)left.R1.Dot(right.C1)
                )
            );
        }
        public static Vector2I2F30 operator *(Matrix2x2I2F30 left, Vector2I2F30 right) {
            var x = left.R0 * right;
            var y = left.R1 * right;
            return new Vector2I2F30(
                x.X + x.Y,
                y.X + y.Y
            );
        }
        #endregion
        #region Transpose
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix2x2I2F30 Transpose() {
            return new Matrix2x2I2F30(
                new Vector2Int32(C0.Repr.X, C1.Repr.X),
                new Vector2Int32(C0.Repr.Y, C1.Repr.Y)
            );
        }
        #endregion
        #region Scale

        /// <summary>
        /// Creates a scaling matrix.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2I2F30 Scale(I2F30 x, I2F30 y) {
            return new Matrix2x2I2F30(
                Vector2I2F30.FromRepr(new Vector2Int32(x.Bits, I2F30.Zero.Bits)),
                Vector2I2F30.FromRepr(new Vector2Int32(I2F30.Zero.Bits, y.Bits))
            );
        }

        /// <summary>
        /// Creates a scaling matrix.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix2x2I2F30 Scale(Vector2I2F30 scale) {
            return Scale(scale.X, scale.Y);
        }
        #endregion
        #region Rotate

        /// <summary>
        /// Create a rotation matrix.
        /// Sine and cosine are approximated by polynomials of degree 2.
        /// </summary>
        public static Matrix2x2I2F30 RotateP2(I17F15 angle) {
            var s = angle.SinP2();
            var c = angle.CosP2();
            return new Matrix2x2I2F30(
                new Vector2I2F30(c, s),
                new Vector2I2F30(-s, c)
            );
        }

        /// <summary>
        /// Create a rotation matrix.
        /// Sine and cosine are approximated by polynomials of degree 3.
        /// </summary>
        public static Matrix2x2I2F30 RotateP3(I17F15 angle) {
            var s = angle.SinP3();
            var c = angle.CosP3();
            return new Matrix2x2I2F30(
                new Vector2I2F30(c, s),
                new Vector2I2F30(-s, c)
            );
        }

        /// <summary>
        /// Create a rotation matrix.
        /// Sine and cosine are approximated by polynomials of degree 4.
        /// </summary>
        public static Matrix2x2I2F30 RotateP4(I17F15 angle) {
            var s = angle.SinP4();
            var c = angle.CosP4();
            return new Matrix2x2I2F30(
                new Vector2I2F30(c, s),
                new Vector2I2F30(-s, c)
            );
        }

        /// <summary>
        /// Create a rotation matrix.
        /// Sine and cosine are approximated by polynomials of degree 5.
        /// </summary>
        public static Matrix2x2I2F30 RotateP5(I17F15 angle) {
            var s = angle.SinP5();
            var c = angle.CosP5();
            return new Matrix2x2I2F30(
                new Vector2I2F30(c, s),
                new Vector2I2F30(-s, c)
            );
        }
        #endregion
    }
} // namespace Intar
