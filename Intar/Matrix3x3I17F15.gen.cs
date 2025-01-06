using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct Matrix3x3I17F15 : IEquatable<Matrix3x3I17F15>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Vector3I17F15 C0;
        public Vector3I17F15 C1;
        public Vector3I17F15 C2;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Matrix3x3I17F15(Vector3Int32 c0Repr, Vector3Int32 c1Repr, Vector3Int32 c2Repr) {
            C0 = new Vector3I17F15(c0Repr);
            C1 = new Vector3I17F15(c1Repr);
            C2 = new Vector3I17F15(c2Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I17F15(Vector3I17F15 c0, Vector3I17F15 c1, Vector3I17F15 c2)
            : this(c0.Repr, c1.Repr, c2.Repr) { }
        #endregion
        #region Identity
        public static readonly Matrix3x3I17F15 Identity = new Matrix3x3I17F15(
            new Vector3Int32(I17F15.OneRepr, 0, 0),
            new Vector3Int32(0, I17F15.OneRepr, 0),
            new Vector3Int32(0, 0, I17F15.OneRepr)
        );
        #endregion
        #region Zero
        public static readonly Matrix3x3I17F15 Zero = new Matrix3x3I17F15(
            new Vector3Int32(0, 0, 0),
            new Vector3Int32(0, 0, 0),
            new Vector3Int32(0, 0, 0)
        );
        #endregion
        #region Properties
        public Vector3I17F15 R0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(new Vector3Int32(C0.Repr.X, C1.Repr.X, C2.Repr.X));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0.Repr.X = value.Repr.X;
                C1.Repr.X = value.Repr.Y;
                C2.Repr.X = value.Repr.Z;
            }
        }
        public Vector3I17F15 R1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(new Vector3Int32(C0.Repr.Y, C1.Repr.Y, C2.Repr.Y));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0.Repr.Y = value.Repr.X;
                C1.Repr.Y = value.Repr.Y;
                C2.Repr.Y = value.Repr.Z;
            }
        }
        public Vector3I17F15 R2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I17F15(new Vector3Int32(C0.Repr.Z, C1.Repr.Z, C2.Repr.Z));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0.Repr.Z = value.Repr.X;
                C1.Repr.Z = value.Repr.Y;
                C2.Repr.Z = value.Repr.Z;
            }
        }
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix3x3I17F15 other) =>
            C0.Equals(other.C0) &&
            C1.Equals(other.C1) &&
            C2.Equals(other.C2);
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Matrix3x3I17F15 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0, C1, C2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"{{ {{C0.X:{C0.X} C1.X:{C1.X} C2.X:{C2.X}}} {{C0.Y:{C0.Y} C1.Y:{C1.Y} C2.Y:{C2.Y}}} {{C0.Z:{C0.Z} C1.Z:{C1.Z} C2.Z:{C2.Z}}} }}";
        }
        #endregion
        #region IFormattable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{ {{C0.X:{C0.X.ToString(format, formatProvider)} C1.X:{C1.X.ToString(format, formatProvider)} C2.X:{C2.X.ToString(format, formatProvider)}}} {{C0.Y:{C0.Y.ToString(format, formatProvider)} C1.Y:{C1.Y.ToString(format, formatProvider)} C2.Y:{C2.Y.ToString(format, formatProvider)}}} {{C0.Z:{C0.Z.ToString(format, formatProvider)} C1.Z:{C1.Z.ToString(format, formatProvider)} C2.Z:{C2.Z.ToString(format, formatProvider)}}} }}";
        }
        #endregion
        #region Conversions
#if UNITY_2018_1_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float3x3(Matrix3x3I17F15 a) {
            return new Unity.Mathematics.float3x3(
                (float)a.C0.X, (float)a.C1.X, (float)a.C2.X,
                (float)a.C0.Y, (float)a.C1.Y, (float)a.C2.Y,
                (float)a.C0.Z, (float)a.C1.Z, (float)a.C2.Z
            );
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion
        #region IAdditionOperators, ISubtractionOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I17F15 operator +(Matrix3x3I17F15 left, Matrix3x3I17F15 right) {
            return new Matrix3x3I17F15(
                left.C0 + right.C0,
                left.C1 + right.C1,
                left.C2 + right.C2
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I17F15 operator -(Matrix3x3I17F15 left, Matrix3x3I17F15 right) {
            return new Matrix3x3I17F15(
                left.C0 - right.C0,
                left.C1 - right.C1,
                left.C2 - right.C2
            );
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I17F15 operator *(Matrix3x3I17F15 left, Matrix3x3I17F15 right) {
            return new Matrix3x3I17F15(
                new Vector3I17F15(
                    (I17F15)left.R0.Dot(right.C0),
                    (I17F15)left.R1.Dot(right.C0),
                    (I17F15)left.R2.Dot(right.C0)
                ),
                new Vector3I17F15(
                    (I17F15)left.R0.Dot(right.C1),
                    (I17F15)left.R1.Dot(right.C1),
                    (I17F15)left.R2.Dot(right.C1)
                ),
                new Vector3I17F15(
                    (I17F15)left.R0.Dot(right.C2),
                    (I17F15)left.R1.Dot(right.C2),
                    (I17F15)left.R2.Dot(right.C2)
                )
            );
        }
        public static Vector3I17F15 operator *(Matrix3x3I17F15 left, Vector3I17F15 right) {
            var x = left.R0 * right;
            var y = left.R1 * right;
            var z = left.R2 * right;
            return new Vector3I17F15(
                x.X + x.Y + x.Z,
                y.X + y.Y + y.Z,
                z.X + z.Y + z.Z
            );
        }
        #endregion
        #region Transpose
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I17F15 Transpose() {
            return new Matrix3x3I17F15(
                new Vector3Int32(C0.Repr.X, C1.Repr.X, C2.Repr.X),
                new Vector3Int32(C0.Repr.Y, C1.Repr.Y, C2.Repr.Y),
                new Vector3Int32(C0.Repr.Z, C1.Repr.Z, C2.Repr.Z)
            );
        }
        #endregion
    }
} // namespace Intar
