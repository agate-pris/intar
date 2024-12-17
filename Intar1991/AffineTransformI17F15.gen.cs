using System;
using System.Runtime.CompilerServices;

namespace Intar1991 {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct AffineTransformI17F15 : IEquatable<AffineTransformI17F15>, IFormattable {
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
        public AffineTransformI17F15(Matrix3x3I17F15 rotationScale, Vector3I17F15 translation) {
            RotationScale = rotationScale;
            Translation = translation;
        }
        #endregion
        #region IEquatable
        public bool Equals(AffineTransformI17F15 other) {
            return RotationScale.Equals(other.RotationScale) && Translation.Equals(other.Translation);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is AffineTransformI17F15 o && Equals(o);
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
        #region IMultiplicationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransformI17F15 operator *(AffineTransformI17F15 left, AffineTransformI17F15 right) {
            return new AffineTransformI17F15(
                left.RotationScale * right.RotationScale,
                left.RotationScale * right.Translation + left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransformI17F15 operator *(AffineTransformI17F15 left, Matrix3x3I17F15 right) {
            return new AffineTransformI17F15(
                left.RotationScale * right, left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransformI17F15 operator *(Matrix3x3I17F15 left, AffineTransformI17F15 right) {
            return new AffineTransformI17F15(
                left * right.RotationScale,
                left * right.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3I17F15 operator *(AffineTransformI17F15 left, Vector3I17F15 right) {
            return left.RotationScale * right + left.Translation;
        }
        #endregion
        #region TRS
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransformI17F15 TRS(Vector3I17F15 translation, QuaternionI2F30 rotation, Vector3I17F15 scale) {
            throw new NotImplementedException();
        }
        #endregion
    }
} // namespace Intar1991
