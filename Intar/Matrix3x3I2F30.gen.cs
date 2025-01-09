using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct Matrix3x3I2F30 : IEquatable<Matrix3x3I2F30>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Vector3I2F30 C0;
        public Vector3I2F30 C1;
        public Vector3I2F30 C2;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Matrix3x3I2F30(Vector3Int32 c0Repr, Vector3Int32 c1Repr, Vector3Int32 c2Repr) {
            C0 = Vector3I2F30.FromRepr(c0Repr);
            C1 = Vector3I2F30.FromRepr(c1Repr);
            C2 = Vector3I2F30.FromRepr(c2Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I2F30(Vector3I2F30 c0, Vector3I2F30 c1, Vector3I2F30 c2)
            : this(c0.Repr, c1.Repr, c2.Repr) { }
        #endregion
        #region Identity
        public static readonly Matrix3x3I2F30 Identity = new Matrix3x3I2F30(
            new Vector3Int32(I2F30.OneRepr, 0, 0),
            new Vector3Int32(0, I2F30.OneRepr, 0),
            new Vector3Int32(0, 0, I2F30.OneRepr)
        );
        #endregion
        #region Zero
        public static readonly Matrix3x3I2F30 Zero = new Matrix3x3I2F30(
            new Vector3Int32(0, 0, 0),
            new Vector3Int32(0, 0, 0),
            new Vector3Int32(0, 0, 0)
        );
        #endregion
        #region Properties
        public Vector3I2F30 R0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector3I2F30.FromRepr(new Vector3Int32(C0.Repr.X, C1.Repr.X, C2.Repr.X));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0.Repr.X = value.Repr.X;
                C1.Repr.X = value.Repr.Y;
                C2.Repr.X = value.Repr.Z;
            }
        }
        public Vector3I2F30 R1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector3I2F30.FromRepr(new Vector3Int32(C0.Repr.Y, C1.Repr.Y, C2.Repr.Y));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0.Repr.Y = value.Repr.X;
                C1.Repr.Y = value.Repr.Y;
                C2.Repr.Y = value.Repr.Z;
            }
        }
        public Vector3I2F30 R2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Vector3I2F30.FromRepr(new Vector3Int32(C0.Repr.Z, C1.Repr.Z, C2.Repr.Z));
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
        public bool Equals(Matrix3x3I2F30 other) =>
            C0.Equals(other.C0) &&
            C1.Equals(other.C1) &&
            C2.Equals(other.C2);
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Matrix3x3I2F30 o && Equals(o);

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
        public static explicit operator Unity.Mathematics.float3x3(Matrix3x3I2F30 a) {
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
        public static Matrix3x3I2F30 operator +(Matrix3x3I2F30 left, Matrix3x3I2F30 right) {
            return new Matrix3x3I2F30(
                left.C0 + right.C0,
                left.C1 + right.C1,
                left.C2 + right.C2
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 operator -(Matrix3x3I2F30 left, Matrix3x3I2F30 right) {
            return new Matrix3x3I2F30(
                left.C0 - right.C0,
                left.C1 - right.C1,
                left.C2 - right.C2
            );
        }
        #endregion
        #region IMultiplyOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 operator *(Matrix3x3I2F30 left, Matrix3x3I2F30 right) {
            return new Matrix3x3I2F30(
                new Vector3I2F30(
                    (I2F30)left.R0.Dot(right.C0),
                    (I2F30)left.R1.Dot(right.C0),
                    (I2F30)left.R2.Dot(right.C0)
                ),
                new Vector3I2F30(
                    (I2F30)left.R0.Dot(right.C1),
                    (I2F30)left.R1.Dot(right.C1),
                    (I2F30)left.R2.Dot(right.C1)
                ),
                new Vector3I2F30(
                    (I2F30)left.R0.Dot(right.C2),
                    (I2F30)left.R1.Dot(right.C2),
                    (I2F30)left.R2.Dot(right.C2)
                )
            );
        }
        public static Vector3I2F30 operator *(Matrix3x3I2F30 left, Vector3I2F30 right) {
            var x = left.R0 * right;
            var y = left.R1 * right;
            var z = left.R2 * right;
            return new Vector3I2F30(
                x.X + x.Y + x.Z,
                y.X + y.Y + y.Z,
                z.X + z.Y + z.Z
            );
        }
        #endregion
        #region Transpose
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I2F30 Transpose() {
            return new Matrix3x3I2F30(
                new Vector3Int32(C0.Repr.X, C1.Repr.X, C2.Repr.X),
                new Vector3Int32(C0.Repr.Y, C1.Repr.Y, C2.Repr.Y),
                new Vector3Int32(C0.Repr.Z, C1.Repr.Z, C2.Repr.Z)
            );
        }
        #endregion
        #region Scale
        /// <summary>
        /// Creates a scaling matrix.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 Scale(I2F30 x, I2F30 y, I2F30 z) {
            return new Matrix3x3I2F30(
                Vector3I2F30.FromRepr(new Vector3Int32(x.Bits, I2F30.Zero.Bits, I2F30.Zero.Bits)),
                Vector3I2F30.FromRepr(new Vector3Int32(I2F30.Zero.Bits, y.Bits, I2F30.Zero.Bits)),
                Vector3I2F30.FromRepr(new Vector3Int32(I2F30.Zero.Bits, I2F30.Zero.Bits, z.Bits))
            );
        }

        /// <summary>
        /// Creates a scaling matrix.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 Scale(Vector3I2F30 scale) {
            return Scale(scale.X, scale.Y, scale.Z);
        }
        #endregion
        #region Conversion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Matrix3x3I2F30(QuaternionI2F30 q) {
            var pnn = new Vector3Int32(+2, -2, -2);
            var npn = new Vector3Int32(-2, +2, -2);
            var nnp = new Vector3Int32(-2, -2, +2);
            return new Matrix3x3I2F30(
                (Vector3Int32)((((q.Repr.YXW().BigMul(q.Repr.Y) * npn) - (q.Repr.ZWX().BigMul(q.Repr.Z) * pnn)) / I2F30.OneRepr) + Vector3I2F30.UnitX.Repr),
                (Vector3Int32)((((q.Repr.WZY().BigMul(q.Repr.Z) * nnp) - (q.Repr.YXW().BigMul(q.Repr.X) * npn)) / I2F30.OneRepr) + Vector3I2F30.UnitY.Repr),
                (Vector3Int32)((((q.Repr.ZWX().BigMul(q.Repr.X) * pnn) - (q.Repr.WZY().BigMul(q.Repr.Y) * nnp)) / I2F30.OneRepr) + Vector3I2F30.UnitZ.Repr)
            );
        }
        #endregion
        #region Rotate X/Y/Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateXP2(I17F15 angle) {
            var s = Mathi.SinP2(angle.Bits);
            var c = Mathi.CosP2(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(I2F30.OneRepr, 0, 0),
                new Vector3Int32(0, c, s),
                new Vector3Int32(0, -s, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateYP2(I17F15 angle) {
            var s = Mathi.SinP2(angle.Bits);
            var c = Mathi.CosP2(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, 0, -s),
                new Vector3Int32(0, I2F30.OneRepr, 0),
                new Vector3Int32(s, 0, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateZP2(I17F15 angle) {
            var s = Mathi.SinP2(angle.Bits);
            var c = Mathi.CosP2(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, s, 0),
                new Vector3Int32(-s, c, 0),
                new Vector3Int32(0, 0, I2F30.OneRepr)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateXP3(I17F15 angle) {
            var s = Mathi.SinP3(angle.Bits);
            var c = Mathi.CosP3(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(I2F30.OneRepr, 0, 0),
                new Vector3Int32(0, c, s),
                new Vector3Int32(0, -s, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateYP3(I17F15 angle) {
            var s = Mathi.SinP3(angle.Bits);
            var c = Mathi.CosP3(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, 0, -s),
                new Vector3Int32(0, I2F30.OneRepr, 0),
                new Vector3Int32(s, 0, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateZP3(I17F15 angle) {
            var s = Mathi.SinP3(angle.Bits);
            var c = Mathi.CosP3(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, s, 0),
                new Vector3Int32(-s, c, 0),
                new Vector3Int32(0, 0, I2F30.OneRepr)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateXP4(I17F15 angle) {
            var s = Mathi.SinP4(angle.Bits);
            var c = Mathi.CosP4(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(I2F30.OneRepr, 0, 0),
                new Vector3Int32(0, c, s),
                new Vector3Int32(0, -s, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateYP4(I17F15 angle) {
            var s = Mathi.SinP4(angle.Bits);
            var c = Mathi.CosP4(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, 0, -s),
                new Vector3Int32(0, I2F30.OneRepr, 0),
                new Vector3Int32(s, 0, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateZP4(I17F15 angle) {
            var s = Mathi.SinP4(angle.Bits);
            var c = Mathi.CosP4(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, s, 0),
                new Vector3Int32(-s, c, 0),
                new Vector3Int32(0, 0, I2F30.OneRepr)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateXP5(I17F15 angle) {
            var s = Mathi.SinP5(angle.Bits);
            var c = Mathi.CosP5(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(I2F30.OneRepr, 0, 0),
                new Vector3Int32(0, c, s),
                new Vector3Int32(0, -s, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateYP5(I17F15 angle) {
            var s = Mathi.SinP5(angle.Bits);
            var c = Mathi.CosP5(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, 0, -s),
                new Vector3Int32(0, I2F30.OneRepr, 0),
                new Vector3Int32(s, 0, c)
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 RotateZP5(I17F15 angle) {
            var s = Mathi.SinP5(angle.Bits);
            var c = Mathi.CosP5(angle.Bits);
            return new Matrix3x3I2F30(
                new Vector3Int32(c, s, 0),
                new Vector3Int32(-s, c, 0),
                new Vector3Int32(0, 0, I2F30.OneRepr)
            );
        }
        #endregion
        #region Euler

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXyzP2(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP2().Repr;
            var c1 = (Vector3Int64)xyz.CosP2().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.Y * s1.Z / k1),
                    -(int)s1.Y),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1)),
                new Vector3Int32(
                    (int)(c2.X * s2.Y * c2.Z / k2) + (int)(s1.X * s1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXzyP2(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP2().Repr;
            var c1 = (Vector3Int64)xyz.CosP2().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)s1.Z,
                    -(int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.X * s1.Y / k1) - (int)(c2.X * c2.Y * s2.Z / k2),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    -(int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1) - (int)(s2.X * s2.Y * s2.Z / k2)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYxzP2(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP2().Repr;
            var c1 = (Vector3Int64)xyz.CosP2().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(c1.Y * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    -(int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)(c1.X * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)s1.X),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    (int)(s1.Y * s1.Z / k1) - (int)(s2.X * c2.Y * c2.Z / k2),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYzxP2(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP2().Repr;
            var c1 = (Vector3Int64)xyz.CosP2().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c2.X * c2.Y * s2.Z / k2) + (int)(s1.X * s1.Y / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)s1.Z,
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Y / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZxyP2(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP2().Repr;
            var c1 = (Vector3Int64)xyz.CosP2().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s2.X * c2.Y * c2.Z / k2) + (int)(s1.Y * s1.Z / k1)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1),
                    -(int)s1.X,
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZyxP2(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP2().Repr;
            var c1 = (Vector3Int64)xyz.CosP2().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    (int)(s1.X * s1.Z / k1) - (int)(c2.X * s2.Y * c2.Z / k2)),
                new Vector3Int32(
                    -(int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(s1.X * c1.Z / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)s1.Y,
                    -(int)(s1.X * c1.Y / k1),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXyzP3(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP3().Repr;
            var c1 = (Vector3Int64)xyz.CosP3().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.Y * s1.Z / k1),
                    -(int)s1.Y),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1)),
                new Vector3Int32(
                    (int)(c2.X * s2.Y * c2.Z / k2) + (int)(s1.X * s1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXzyP3(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP3().Repr;
            var c1 = (Vector3Int64)xyz.CosP3().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)s1.Z,
                    -(int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.X * s1.Y / k1) - (int)(c2.X * c2.Y * s2.Z / k2),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    -(int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1) - (int)(s2.X * s2.Y * s2.Z / k2)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYxzP3(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP3().Repr;
            var c1 = (Vector3Int64)xyz.CosP3().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(c1.Y * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    -(int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)(c1.X * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)s1.X),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    (int)(s1.Y * s1.Z / k1) - (int)(s2.X * c2.Y * c2.Z / k2),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYzxP3(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP3().Repr;
            var c1 = (Vector3Int64)xyz.CosP3().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c2.X * c2.Y * s2.Z / k2) + (int)(s1.X * s1.Y / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)s1.Z,
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Y / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZxyP3(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP3().Repr;
            var c1 = (Vector3Int64)xyz.CosP3().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s2.X * c2.Y * c2.Z / k2) + (int)(s1.Y * s1.Z / k1)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1),
                    -(int)s1.X,
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZyxP3(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP3().Repr;
            var c1 = (Vector3Int64)xyz.CosP3().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    (int)(s1.X * s1.Z / k1) - (int)(c2.X * s2.Y * c2.Z / k2)),
                new Vector3Int32(
                    -(int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(s1.X * c1.Z / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)s1.Y,
                    -(int)(s1.X * c1.Y / k1),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXyzP4(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP4().Repr;
            var c1 = (Vector3Int64)xyz.CosP4().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.Y * s1.Z / k1),
                    -(int)s1.Y),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1)),
                new Vector3Int32(
                    (int)(c2.X * s2.Y * c2.Z / k2) + (int)(s1.X * s1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXzyP4(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP4().Repr;
            var c1 = (Vector3Int64)xyz.CosP4().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)s1.Z,
                    -(int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.X * s1.Y / k1) - (int)(c2.X * c2.Y * s2.Z / k2),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    -(int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1) - (int)(s2.X * s2.Y * s2.Z / k2)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYxzP4(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP4().Repr;
            var c1 = (Vector3Int64)xyz.CosP4().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(c1.Y * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    -(int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)(c1.X * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)s1.X),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    (int)(s1.Y * s1.Z / k1) - (int)(s2.X * c2.Y * c2.Z / k2),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYzxP4(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP4().Repr;
            var c1 = (Vector3Int64)xyz.CosP4().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c2.X * c2.Y * s2.Z / k2) + (int)(s1.X * s1.Y / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)s1.Z,
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Y / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZxyP4(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP4().Repr;
            var c1 = (Vector3Int64)xyz.CosP4().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s2.X * c2.Y * c2.Z / k2) + (int)(s1.Y * s1.Z / k1)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1),
                    -(int)s1.X,
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZyxP4(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP4().Repr;
            var c1 = (Vector3Int64)xyz.CosP4().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    (int)(s1.X * s1.Z / k1) - (int)(c2.X * s2.Y * c2.Z / k2)),
                new Vector3Int32(
                    -(int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(s1.X * c1.Z / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)s1.Y,
                    -(int)(s1.X * c1.Y / k1),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXyzP5(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP5().Repr;
            var c1 = (Vector3Int64)xyz.CosP5().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.Y * s1.Z / k1),
                    -(int)s1.Y),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1)),
                new Vector3Int32(
                    (int)(c2.X * s2.Y * c2.Z / k2) + (int)(s1.X * s1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerXzyP5(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP5().Repr;
            var c1 = (Vector3Int64)xyz.CosP5().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)s1.Z,
                    -(int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.X * s1.Y / k1) - (int)(c2.X * c2.Y * s2.Z / k2),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Y / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    -(int)(s1.X * c1.Z / k1),
                    (int)(c1.X * c1.Y / k1) - (int)(s2.X * s2.Y * s2.Z / k2)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYxzP5(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP5().Repr;
            var c1 = (Vector3Int64)xyz.CosP5().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(c1.Y * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    -(int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)(c1.X * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)s1.X),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1) + (int)(s2.X * c2.Y * s2.Z / k2),
                    (int)(s1.Y * s1.Z / k1) - (int)(s2.X * c2.Y * c2.Z / k2),
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerYzxP5(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP5().Repr;
            var c1 = (Vector3Int64)xyz.CosP5().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c2.X * c2.Y * s2.Z / k2) + (int)(s1.X * s1.Y / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(c1.X * s1.Y / k1)),
                new Vector3Int32(
                    -(int)s1.Z,
                    (int)(c1.X * c1.Z / k1),
                    (int)(s1.X * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s1.Y * c1.Z / k1),
                    (int)(c2.X * s2.Y * s2.Z / k2) - (int)(s1.X * c1.Y / k1),
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZxyP5(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP5().Repr;
            var c1 = (Vector3Int64)xyz.CosP5().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(s2.X * s2.Y * s2.Z / k2) + (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1),
                    (int)(s2.X * c2.Y * s2.Z / k2) - (int)(s1.Y * c1.Z / k1)),
                new Vector3Int32(
                    (int)(s2.X * s2.Y * c2.Z / k2) - (int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1),
                    (int)(s2.X * c2.Y * c2.Z / k2) + (int)(s1.Y * s1.Z / k1)),
                new Vector3Int32(
                    (int)(c1.X * s1.Y / k1),
                    -(int)s1.X,
                    (int)(c1.X * c1.Y / k1)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 EulerZyxP5(Vector3I17F15 xyz) {
            var s1 = (Vector3Int64)xyz.SinP5().Repr;
            var c1 = (Vector3Int64)xyz.CosP5().Repr;

            // 3 回掛けてもオーバーフローが起きないようにする。
            var s2 = s1 / (1 << 10);
            var c2 = c1 / (1 << 10);
            var k1 = (long)1 << 30;
            var k2 = (long)1 << 30;
            return new Matrix3x3I2F30(
                new Vector3Int32(
                    (int)(c1.Y * c1.Z / k1),
                    (int)(c1.X * s1.Z / k1) + (int)(s2.X * s2.Y * c2.Z / k2),
                    (int)(s1.X * s1.Z / k1) - (int)(c2.X * s2.Y * c2.Z / k2)),
                new Vector3Int32(
                    -(int)(c1.Y * s1.Z / k1),
                    (int)(c1.X * c1.Z / k1) - (int)(s2.X * s2.Y * s2.Z / k2),
                    (int)(s1.X * c1.Z / k1) + (int)(c2.X * s2.Y * s2.Z / k2)),
                new Vector3Int32(
                    (int)s1.Y,
                    -(int)(s1.X * c1.Y / k1),
                    (int)(c1.X * c1.Y / k1)));
        }
        #endregion
        #region AxisAngle

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 AxisAngleP2(Vector3I2F30 axis, I17F15 angle) {
            var sin = angle.SinP2();
            var cos = angle.CosP2();

            var perpendicularComponent = axis - (axis * cos);

            Vector4I2F30 rotationHelper;
            {
                var xyz = axis * sin;
                rotationHelper = new Vector4I2F30(xyz.X, xyz.Y, xyz.Z, cos);
            }

            var ppn = new Vector3Int32(+1, +1, -1);
            var npp = new Vector3Int32(-1, +1, +1);
            var pnp = new Vector3Int32(+1, -1, +1);

            return new Matrix3x3I2F30(
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.X) / I2F30.OneRepr) + rotationHelper.Repr.WZY().BigMul(ppn)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Y) / I2F30.OneRepr) + rotationHelper.Repr.ZWX().BigMul(npp)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Z) / I2F30.OneRepr) + rotationHelper.Repr.YXW().BigMul(pnp))
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 AxisAngleP3(Vector3I2F30 axis, I17F15 angle) {
            var sin = angle.SinP3();
            var cos = angle.CosP3();

            var perpendicularComponent = axis - (axis * cos);

            Vector4I2F30 rotationHelper;
            {
                var xyz = axis * sin;
                rotationHelper = new Vector4I2F30(xyz.X, xyz.Y, xyz.Z, cos);
            }

            var ppn = new Vector3Int32(+1, +1, -1);
            var npp = new Vector3Int32(-1, +1, +1);
            var pnp = new Vector3Int32(+1, -1, +1);

            return new Matrix3x3I2F30(
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.X) / I2F30.OneRepr) + rotationHelper.Repr.WZY().BigMul(ppn)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Y) / I2F30.OneRepr) + rotationHelper.Repr.ZWX().BigMul(npp)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Z) / I2F30.OneRepr) + rotationHelper.Repr.YXW().BigMul(pnp))
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 AxisAngleP4(Vector3I2F30 axis, I17F15 angle) {
            var sin = angle.SinP4();
            var cos = angle.CosP4();

            var perpendicularComponent = axis - (axis * cos);

            Vector4I2F30 rotationHelper;
            {
                var xyz = axis * sin;
                rotationHelper = new Vector4I2F30(xyz.X, xyz.Y, xyz.Z, cos);
            }

            var ppn = new Vector3Int32(+1, +1, -1);
            var npp = new Vector3Int32(-1, +1, +1);
            var pnp = new Vector3Int32(+1, -1, +1);

            return new Matrix3x3I2F30(
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.X) / I2F30.OneRepr) + rotationHelper.Repr.WZY().BigMul(ppn)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Y) / I2F30.OneRepr) + rotationHelper.Repr.ZWX().BigMul(npp)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Z) / I2F30.OneRepr) + rotationHelper.Repr.YXW().BigMul(pnp))
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 AxisAngleP5(Vector3I2F30 axis, I17F15 angle) {
            var sin = angle.SinP5();
            var cos = angle.CosP5();

            var perpendicularComponent = axis - (axis * cos);

            Vector4I2F30 rotationHelper;
            {
                var xyz = axis * sin;
                rotationHelper = new Vector4I2F30(xyz.X, xyz.Y, xyz.Z, cos);
            }

            var ppn = new Vector3Int32(+1, +1, -1);
            var npp = new Vector3Int32(-1, +1, +1);
            var pnp = new Vector3Int32(+1, -1, +1);

            return new Matrix3x3I2F30(
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.X) / I2F30.OneRepr) + rotationHelper.Repr.WZY().BigMul(ppn)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Y) / I2F30.OneRepr) + rotationHelper.Repr.ZWX().BigMul(npp)),
                (Vector3Int32)((perpendicularComponent.Repr.BigMul(axis.Repr.Z) / I2F30.OneRepr) + rotationHelper.Repr.YXW().BigMul(pnp))
            );
        }
        #endregion
        #region LookRotation, LookRotationSafe
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30 LookRotation(Vector3I2F30 forward, Vector3I2F30 up) {
            var c0 = Vector3I2F30.FromRepr((Vector3Int32)(up.Cross(forward).Repr / I2F30.OneRepr)).Normalize().Value;
            var c1 = Vector3I2F30.FromRepr((Vector3Int32)(forward.Cross(c0).Repr / I2F30.OneRepr));
            return new Matrix3x3I2F30(c0.Repr, c1.Repr, forward.Repr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix3x3I2F30? LookRotationSafe(Vector3I2F30 forward, Vector3I2F30 up) {
            var f = forward.Normalize();
            var u = up.Normalize();
            if (!f.HasValue || !u.HasValue) {
                return null;
            }
            var c0 = Vector3I2F30.FromRepr((Vector3Int32)(u.Value.Cross(f.Value).Repr / I2F30.OneRepr)).Normalize();
            if (!c0.HasValue) {
                return null;
            }

            var c1 = Vector3I2F30.FromRepr((Vector3Int32)(f.Value.Cross(c0.Value).Repr / I2F30.OneRepr));
            return new Matrix3x3I2F30(c0.Value.Repr, c1.Repr, f.Value.Repr);
        }
        #endregion
    }
} // namespace Intar
