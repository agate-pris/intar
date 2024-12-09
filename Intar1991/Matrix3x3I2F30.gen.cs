using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct Matrix3x3I2F30 : IEquatable<Matrix3x3I2F30> {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region Fields
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif
        public Vector3Int32 C0Repr;
        public Vector3Int32 C1Repr;
        public Vector3Int32 C2Repr;
#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #endregion
        #region Constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Matrix3x3I2F30(Vector3Int32 c0Repr, Vector3Int32 c1Repr, Vector3Int32 c2Repr) {
            C0Repr = c0Repr;
            C1Repr = c1Repr;
            C2Repr = c2Repr;
        }
        #endregion
        #region Properties
        public Vector3I2F30 C0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(C0Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => C0Repr = value.Repr;
        }
        public Vector3I2F30 C1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(C1Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => C1Repr = value.Repr;
        }
        public Vector3I2F30 C2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(C2Repr);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => C2Repr = value.Repr;
        }
        public Vector3I2F30 R0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(new Vector3Int32(C0Repr.X, C1Repr.X, C2Repr.X));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0Repr.X = value.Repr.X;
                C1Repr.X = value.Repr.Y;
                C2Repr.X = value.Repr.Z;
            }
        }
        public Vector3I2F30 R1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(new Vector3Int32(C0Repr.Y, C1Repr.Y, C2Repr.Y));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0Repr.Y = value.Repr.X;
                C1Repr.Y = value.Repr.Y;
                C2Repr.Y = value.Repr.Z;
            }
        }
        public Vector3I2F30 R2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new Vector3I2F30(new Vector3Int32(C0Repr.Z, C1Repr.Z, C2Repr.Z));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                C0Repr.Z = value.Repr.X;
                C1Repr.Z = value.Repr.Y;
                C2Repr.Z = value.Repr.Z;
            }
        }
        #endregion
        #region Object
        public override bool Equals(object obj) => obj is Matrix3x3I2F30 o && Equals(o);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(C0Repr, C1Repr, C2Repr);
        #endregion
        #region IEquatable
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Matrix3x3I2F30 other) =>
            C0Repr.Equals(other.C0Repr) &&
            C1Repr.Equals(other.C1Repr) &&
            C2Repr.Equals(other.C2Repr);
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
    }
} // namespace Intar1991
