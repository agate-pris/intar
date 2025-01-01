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
        #region Fields
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
                a.RotationScale.C0.X.LossyToSingle(), a.RotationScale.C0.Y.LossyToSingle(), a.RotationScale.C0.Z.LossyToSingle(), 0,
                a.RotationScale.C1.X.LossyToSingle(), a.RotationScale.C1.Y.LossyToSingle(), a.RotationScale.C1.Z.LossyToSingle(), 0,
                a.RotationScale.C2.X.LossyToSingle(), a.RotationScale.C2.Y.LossyToSingle(), a.RotationScale.C2.Z.LossyToSingle(), 0,
                a.Translation.X.LossyToSingle(), a.Translation.Y.LossyToSingle(), a.Translation.Z.LossyToSingle(), 1
            );
        }

#if UNITY_5_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UnityEngine.Matrix4x4(AffineTransform3I17F15 a) {
            return new UnityEngine.Matrix4x4(
                new UnityEngine.Vector4(a.RotationScale.C0.X.LossyToSingle(), a.RotationScale.C0.Y.LossyToSingle(), a.RotationScale.C0.Z.LossyToSingle(), 0),
                new UnityEngine.Vector4(a.RotationScale.C1.X.LossyToSingle(), a.RotationScale.C1.Y.LossyToSingle(), a.RotationScale.C1.Z.LossyToSingle(), 0),
                new UnityEngine.Vector4(a.RotationScale.C2.X.LossyToSingle(), a.RotationScale.C2.Y.LossyToSingle(), a.RotationScale.C2.Z.LossyToSingle(), 0),
                new UnityEngine.Vector4(a.Translation.X.LossyToSingle(), a.Translation.Y.LossyToSingle(), a.Translation.Z.LossyToSingle(), 1)
            );
        }
#endif // UNITY_5_3_OR_NEWER

#if UNITY_2018_1_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float4x4(AffineTransform3I17F15 a) {
            return new Unity.Mathematics.float4x4(
                a.RotationScale.C0.X.LossyToSingle(), a.RotationScale.C1.X.LossyToSingle(), a.RotationScale.C2.X.LossyToSingle(), a.Translation.X.LossyToSingle(),
                a.RotationScale.C0.Y.LossyToSingle(), a.RotationScale.C1.Y.LossyToSingle(), a.RotationScale.C2.Y.LossyToSingle(), a.Translation.Y.LossyToSingle(),
                a.RotationScale.C0.Z.LossyToSingle(), a.RotationScale.C1.Z.LossyToSingle(), a.RotationScale.C2.Z.LossyToSingle(), a.Translation.Z.LossyToSingle(),
                0, 0, 0, 1
            );
        }
#endif // UNITY_2018_1_OR_NEWER
        #endregion
        #region IMultiplicationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform3I17F15 operator *(AffineTransform3I17F15 left, AffineTransform3I17F15 right) {
            return new AffineTransform3I17F15(
                left.RotationScale * right.RotationScale,
                left.RotationScale * right.Translation + left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(AffineTransform3I17F15 left, Vector3I17F15 right) {
            return left.RotationScale * right + left.Translation;
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
        public static AffineTransform3I17F15 Trs(Vector3I17F15 translation, QuaternionI2F30 rotation, Vector3I17F15 scale) {
            // クォータニオンから行列への変換時
            // 内部的に long を経由するが,
            // 小数部の精度が大きいまま更にスケールを乗算すると
            // オーバーフローを引き起こすため,
            // 素直に一度小数部の精度を減らしてから乗算する.
            var r = (Matrix3x3I2F30)rotation;
            var c0 = new Vector3I17F15((Vector3Int32)(r.C0.Repr.BigMul(scale.Repr.X) / (1 << 30)));
            var c1 = new Vector3I17F15((Vector3Int32)(r.C1.Repr.BigMul(scale.Repr.Y) / (1 << 30)));
            var c2 = new Vector3I17F15((Vector3Int32)(r.C2.Repr.BigMul(scale.Repr.Z) / (1 << 30)));
            return new AffineTransform3I17F15(new Matrix3x3I17F15(c0, c1, c2), translation);
        }
        #endregion
        #region DecomposeScale
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3I17F15 DecomposeScale() => new Vector3I17F15(
            I17F15.UncheckedFrom(RotationScale.C0.Length()),
            I17F15.UncheckedFrom(RotationScale.C1.Length()),
            I17F15.UncheckedFrom(RotationScale.C2.Length())
        );
        #endregion
    }
} // namespace Intar
