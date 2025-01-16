using System;
using System.Runtime.CompilerServices;

namespace Intar {
    [Serializable]
#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#endif
    public struct AffineTransform2I17F15 : IEquatable<AffineTransform2I17F15>, IFormattable {
#if NET5_0_OR_GREATER
#pragma warning restore CA2231 // 値型 Equals のオーバーライドで、演算子 equals をオーバーロードします
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif
        #region RotationScale, Translation

#if NET5_0_OR_GREATER
#pragma warning disable IDE0079 // 不要な抑制を削除します
#pragma warning disable CA1051 // 参照可能なインスタンス フィールドを宣言しません
#endif

        public Matrix2x2I17F15 RotationScale;
        public Vector2I17F15 Translation;

#if NET5_0_OR_GREATER
#pragma warning restore CA1051 // 参照可能なインスタンス フィールドを宣言しません
#pragma warning restore IDE0079 // 不要な抑制を削除します
#endif

        #endregion
        #region Constructors
        public AffineTransform2I17F15(Matrix2x2I17F15 rotationScale, Vector2I17F15 translation) {
            RotationScale = rotationScale;
            Translation = translation;
        }
        #endregion
        #region IEquatable
        public bool Equals(AffineTransform2I17F15 other) {
            return RotationScale.Equals(other.RotationScale) && Translation.Equals(other.Translation);
        }
        #endregion
        #region Object
        public override bool Equals(object obj) {
            return obj is AffineTransform2I17F15 o && Equals(o);
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

#if UNITY_2018_1_OR_NEWER

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Unity.Mathematics.float3x3(AffineTransform2I17F15 a) {
            return new Unity.Mathematics.float3x3(
                (float)a.RotationScale.C0.X, (float)a.RotationScale.C1.X, (float)a.Translation.X,
                (float)a.RotationScale.C0.Y, (float)a.RotationScale.C1.Y, (float)a.Translation.Y,
                0, 0, 1
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator AffineTransform2I17F15(Unity.Mathematics.float3x3 a) {

#if UNITY_ASSERTIONS

            UnityEngine.Assertions.Assert.IsTrue(
                a.c0.z == 0 &&
                a.c1.z == 0 &&
                a.c2.z == 1
            );

#endif // UNITY_ASSERTIONS

            return new AffineTransform2I17F15(
                new Matrix2x2I17F15(
                    new Vector2I17F15((I17F15)a.c0.x, (I17F15)a.c0.y),
                    new Vector2I17F15((I17F15)a.c1.x, (I17F15)a.c1.y)
                ),
                new Vector2I17F15((I17F15)a.c2.x, (I17F15)a.c2.y)
            );
        }

#endif // UNITY_2018_1_OR_NEWER

        #endregion
        #region IMultiplicationOperators
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform2I17F15 operator *(AffineTransform2I17F15 left, AffineTransform2I17F15 right) {
            return new AffineTransform2I17F15(
                left.RotationScale * right.RotationScale,
                (left.RotationScale * right.Translation) + left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2I17F15 operator *(AffineTransform2I17F15 left, Vector2I17F15 right) {
            return (left.RotationScale * right) + left.Translation;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform2I17F15 operator *(AffineTransform2I17F15 left, Matrix2x2I17F15 right) {
            return new AffineTransform2I17F15(
                left.RotationScale * right, left.Translation
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform2I17F15 operator *(Matrix2x2I17F15 left, AffineTransform2I17F15 right) {
            return new AffineTransform2I17F15(
                left * right.RotationScale,
                left * right.Translation
            );
        }
        #endregion
        #region Trs
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static AffineTransform2I17F15 Trs(Vector2I17F15 translation, I2F30 s, I2F30 c, Vector2I17F15 scale) {
            var c0 = new Vector2Int32(c.Bits, s.Bits);
            var c1 = new Vector2Int32(-s.Bits, c.Bits);
            var rotationScale = new Matrix2x2I17F15(
                Vector2I17F15.FromRepr((Vector2Int32)(c0.BigMul(scale.Repr.X) / (1 << 30))),
                Vector2I17F15.FromRepr((Vector2Int32)(c1.BigMul(scale.Repr.Y) / (1 << 30)))
            );
            return new AffineTransform2I17F15(rotationScale, translation);
        }

        /// <summary>
        /// Create a new <see cref="AffineTransform2I17F15"/> instance with the specified translation, rotation, and scale.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform2I17F15 TrsP2(Vector2I17F15 translation, I17F15 rotation, Vector2I17F15 scale) {
            var s = rotation.SinP2();
            var c = rotation.CosP2();
            return Trs(translation, s, c, scale);
        }

        /// <summary>
        /// Create a new <see cref="AffineTransform2I17F15"/> instance with the specified translation, rotation, and scale.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform2I17F15 TrsP3(Vector2I17F15 translation, I17F15 rotation, Vector2I17F15 scale) {
            var s = rotation.SinP3();
            var c = rotation.CosP3();
            return Trs(translation, s, c, scale);
        }

        /// <summary>
        /// Create a new <see cref="AffineTransform2I17F15"/> instance with the specified translation, rotation, and scale.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform2I17F15 TrsP4(Vector2I17F15 translation, I17F15 rotation, Vector2I17F15 scale) {
            var s = rotation.SinP4();
            var c = rotation.CosP4();
            return Trs(translation, s, c, scale);
        }

        /// <summary>
        /// Create a new <see cref="AffineTransform2I17F15"/> instance with the specified translation, rotation, and scale.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform2I17F15 TrsP5(Vector2I17F15 translation, I17F15 rotation, Vector2I17F15 scale) {
            var s = rotation.SinP5();
            var c = rotation.CosP5();
            return Trs(translation, s, c, scale);
        }
        #endregion
        #region DecomposeScaleX, DecomposeScaleY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 DecomposeScaleX() => RotationScale.C0.Length();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public U17F15 DecomposeScaleY() => RotationScale.C1.Length();
        #endregion
    }
} // namespace Intar
