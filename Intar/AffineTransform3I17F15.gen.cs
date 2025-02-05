using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct AffineTransform3I17F15 : IEquatable<AffineTransform3I17F15>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region RotationScale, Translation

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Matrix3x3I17F15 RotationScale;
        public Vector3I17F15 Translation;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Constructors
        public AffineTransform3I17F15(Matrix3x3I17F15 rotationScale, Vector3I17F15 translation) {
            RotationScale = rotationScale;
            Translation = translation;
        }
        #endregion
        #region IEquatable
        public bool Equals(AffineTransform3I17F15 other) {
            return RotationScale.Equals(other.RotationScale) && Translation.Equals(other.Translation);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is AffineTransform3I17F15 o && Equals(o);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => HashCode.Combine(
            RotationScale, Translation
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() {
            return $"{{RotationScale:{RotationScale} Translation:{Translation}}}";
        }
        #endregion
        #region IFormattable
        public string ToString(string format, IFormatProvider formatProvider) {
            return $"{{RotationScale:{RotationScale.ToString(format, formatProvider)} Translation:{Translation.ToString(format, formatProvider)}}}";
        }
        #endregion
        #region Conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator System.Numerics.Matrix4x4(AffineTransform3I17F15 a) {
            return new System.Numerics.Matrix4x4(
                (float)a.RotationScale.C0.X, (float)a.RotationScale.C0.Y, (float)a.RotationScale.C0.Z, 0,
                (float)a.RotationScale.C1.X, (float)a.RotationScale.C1.Y, (float)a.RotationScale.C1.Z, 0,
                (float)a.RotationScale.C2.X, (float)a.RotationScale.C2.Y, (float)a.RotationScale.C2.Z, 0,
                (float)a.Translation.X, (float)a.Translation.Y, (float)a.Translation.Z, 1
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator AffineTransform3I17F15(System.Numerics.Matrix4x4 a) {

#if UNITY_ASSERTIONS

            UnityEngine.Assertions.Assert.IsTrue(
                a.M14 == 0 &&
                a.M24 == 0 &&
                a.M34 == 0 &&
                a.M44 == 1
            );

#endif // UNITY_ASSERTIONS

            return new AffineTransform3I17F15(
                new Matrix3x3I17F15(
                    new Vector3I17F15((I17F15)a.M11, (I17F15)a.M12, (I17F15)a.M13),
                    new Vector3I17F15((I17F15)a.M21, (I17F15)a.M22, (I17F15)a.M23),
                    new Vector3I17F15((I17F15)a.M31, (I17F15)a.M32, (I17F15)a.M33)
                ),
                new Vector3I17F15((I17F15)a.M41, (I17F15)a.M42, (I17F15)a.M43)
            );
        }

#if UNITY_5_3_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UnityEngine.Matrix4x4(AffineTransform3I17F15 a) {
            return new UnityEngine.Matrix4x4(
                new UnityEngine.Vector4((float)a.RotationScale.C0.X, (float)a.RotationScale.C0.Y, (float)a.RotationScale.C0.Z, 0),
                new UnityEngine.Vector4((float)a.RotationScale.C1.X, (float)a.RotationScale.C1.Y, (float)a.RotationScale.C1.Z, 0),
                new UnityEngine.Vector4((float)a.RotationScale.C2.X, (float)a.RotationScale.C2.Y, (float)a.RotationScale.C2.Z, 0),
                new UnityEngine.Vector4((float)a.Translation.X, (float)a.Translation.Y, (float)a.Translation.Z, 1)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator AffineTransform3I17F15(UnityEngine.Matrix4x4 a) {

#if UNITY_ASSERTIONS

            UnityEngine.Assertions.Assert.IsTrue(
                a.m30 == 0 &&
                a.m31 == 0 &&
                a.m32 == 0 &&
                a.m33 == 1
            );

#endif // UNITY_ASSERTIONS

            return new AffineTransform3I17F15(
                new Matrix3x3I17F15(
                    new Vector3I17F15((I17F15)a.m00, (I17F15)a.m10, (I17F15)a.m20),
                    new Vector3I17F15((I17F15)a.m01, (I17F15)a.m11, (I17F15)a.m21),
                    new Vector3I17F15((I17F15)a.m02, (I17F15)a.m12, (I17F15)a.m22)
                ),
                new Vector3I17F15((I17F15)a.m03, (I17F15)a.m13, (I17F15)a.m23)
            );
        }

#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float4x4(AffineTransform3I17F15 a) {
            return new Unity.Mathematics.float4x4(
                (float)a.RotationScale.C0.X, (float)a.RotationScale.C1.X, (float)a.RotationScale.C2.X, (float)a.Translation.X,
                (float)a.RotationScale.C0.Y, (float)a.RotationScale.C1.Y, (float)a.RotationScale.C2.Y, (float)a.Translation.Y,
                (float)a.RotationScale.C0.Z, (float)a.RotationScale.C1.Z, (float)a.RotationScale.C2.Z, (float)a.Translation.Z,
                0, 0, 0, 1
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator AffineTransform3I17F15(Unity.Mathematics.float4x4 a) {

#if UNITY_ASSERTIONS

            UnityEngine.Assertions.Assert.IsTrue(
                a.c0.w == 0 &&
                a.c1.w == 0 &&
                a.c2.w == 0 &&
                a.c3.w == 1
            );

#endif // UNITY_ASSERTIONS

            return new AffineTransform3I17F15(
                new Matrix3x3I17F15(
                    new Vector3I17F15((I17F15)a.c0.x, (I17F15)a.c0.y, (I17F15)a.c0.z),
                    new Vector3I17F15((I17F15)a.c1.x, (I17F15)a.c1.y, (I17F15)a.c1.z),
                    new Vector3I17F15((I17F15)a.c2.x, (I17F15)a.c2.y, (I17F15)a.c2.z)
                ),
                new Vector3I17F15((I17F15)a.c3.x, (I17F15)a.c3.y, (I17F15)a.c3.z)
            );
        }

#endif // UNITY_2018_1_OR_NEWER

        #endregion
        #region IMultiplicationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform3I17F15 operator *(AffineTransform3I17F15 left, AffineTransform3I17F15 right) {
            return new AffineTransform3I17F15(
                left.RotationScale * right.RotationScale,
                (left.RotationScale * right.Translation) + left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(AffineTransform3I17F15 left, Vector3I17F15 right) {
            return (left.RotationScale * right) + left.Translation;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform3I17F15 operator *(AffineTransform3I17F15 left, Matrix3x3I17F15 right) {
            return new AffineTransform3I17F15(
                left.RotationScale * right, left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform3I17F15 operator *(Matrix3x3I17F15 left, AffineTransform3I17F15 right) {
            return new AffineTransform3I17F15(
                left * right.RotationScale,
                left * right.Translation
            );
        }
        #endregion
        #region Trs
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform3I17F15 Trs(Vector3I17F15 translation, Matrix3x3I2F30 rotation, Vector3I17F15 scale) {
            var c0 = Vector3I17F15.FromRepr((Vector3Int32)(rotation.C0.Repr.BigMul(scale.Repr.X) / (1 << 30)));
            var c1 = Vector3I17F15.FromRepr((Vector3Int32)(rotation.C1.Repr.BigMul(scale.Repr.Y) / (1 << 30)));
            var c2 = Vector3I17F15.FromRepr((Vector3Int32)(rotation.C2.Repr.BigMul(scale.Repr.Z) / (1 << 30)));
            return new AffineTransform3I17F15(new Matrix3x3I17F15(c0, c1, c2), translation);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform3I17F15 Trs(Vector3I17F15 translation, QuaternionI2F30 rotation, Vector3I17F15 scale) {
            // クォータニオンから行列への変換時
            // 内部的に long を経由するが,
            // 小数部の精度が大きいまま更にスケールを乗算すると
            // オーバーフローを引き起こすため,
            // 素直に一度小数部の精度を減らしてから乗算する.
            var r = (Matrix3x3I2F30)rotation;
            return Trs(translation, r, scale);
        }
        #endregion
        #region DecomposeScaleX, DecomposeScaleY, DecomposeScaleZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 DecomposeScaleX() => RotationScale.C0.Length();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 DecomposeScaleY() => RotationScale.C1.Length();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 DecomposeScaleZ() => RotationScale.C2.Length();
        #endregion
    }
} // namespace Intar
